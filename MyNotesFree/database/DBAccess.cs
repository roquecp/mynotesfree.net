/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 19/07/2019
 */
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using MyNotesFree.database.dao;
using MyNotesFree.database.entity;

namespace MyNotesFree.database
{
	/// <summary>
	/// Classe que conecta ao DB e realiza algumas operações específicas
	/// </summary>
	public static class DBAccess
	{
		private static SQLiteConnection conn = null;
		private static string connectionString = "Data Source=";
		private static readonly string DATABASE_LOCATION = Directory.GetCurrentDirectory();
		
		const string FILENAME = "MyNotes.net.db";
		
	  	const string CREATE_CONFIG = "create table configuration " +
		    "(editorFont Text(50), 		editorFontSize Integer, " +
		     "editorFontColor Text(50), editorFontStyle Text(50), " +
		     "minOnClose Integer(1), 	startMinimized Integer(1), " +
		     "updatePeriod Integer(1), 	nextUpdate DateTime, " +
		     "useProxy Integer(1), 		proxyServer Text(50), " +
		     "proxyPort Integer(6), 	proxyUser Text(50), " +
		     "proxyPass Text(50), 		shortcutMyNotes Text(20), " +
		     "shortcutQuickNotes Text(20), showCodCateg Integer(1))";

  		const string CREATE_CATEGS = "create table category " +
		    "(id Integer Primary Key ASC, " +
		     "description Text(50), " +
		     "color Text(20), " +
		     "font Text(20), " +
		     "selected Integer(1), " +
		     "mustHide Integer(1), " +
		     "editable Integer(1))";

  		const string CREATE_NOTES = "create table note " +
		    "(id Integer Primary Key ASC, " +
		     "title Text(250), " +
		     "createdAt Text(20), " +
		     "updatedAt Text(20), " +
		     "text BLOB, " +
		     "categoryId Integer, " +
		     "password Text(20)," +
  			 "position Integer)";

  		/**
  		 * Conecta no banco de dados, criando-o caso necessário
  		 */
  		public static SQLiteConnection getConnection()
		{
  			
			if (conn == null) {
				connectionString += DATABASE_LOCATION;
				bool hasFile = File.Exists(DATABASE_LOCATION + "\\" + FILENAME);
				
				conn = new SQLiteConnection(connectionString + "\\" + FILENAME);
				conn.Open();  //Se o .DB não existir, será criado
				if (!hasFile) {
					//O arquivo não existia, precisa criar as tabelas
					SQLiteCommand cmd = getCommand(CREATE_CONFIG);
					cmd.ExecuteNonQuery();
					
					cmd.CommandText = CREATE_CATEGS;
					cmd.ExecuteNonQuery();
					
					cmd.CommandText = CREATE_NOTES;
					cmd.ExecuteNonQuery();
					
					insertDefaultCategories(conn, "Geral", "White", "Lucida Console", 1, 0, 0);
					insertDefaultCategories(conn, "Lixeira", "White", "Lucida Console", 0, 0, 0);
					
					insertWelcomeNote(conn);
  				}
			}
			return conn;
		}
  		
  		private static void insertWelcomeNote(SQLiteConnection conn) {
  			Annotation note = new Annotation();
  			note.Id = 1;
  			note.Title = "Bem vindo ao MyNotesFree.net";
  			note.Text = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1046{\fonttbl{\f0\fnil\fcharset0 Verdana;}{\f1\fnil Lucida Console;}{\f2\fnil\fcharset0 Lucida Console;}{\f3\fnil MS Sans Serif;}{\f4\fnil\fcharset2 Symbol;}}" + 
  				@"{\colortbl ;\red0\green0\blue0;\red0\green0\blue255;}" +
      			@"\viewkind4\uc1\pard\cf1\f0\fs18" +
      			@"\par \b\fs28 Seja bem vindo ao \cf2 MyNotesFree\cf1 , o seu organizador de anota\''e7\''f5es!" +
      			@"\par \b0\fs18" +
      			@"\par \pard{\pntext\f4\''B7\tab}{\*\pn\pnlvlblt\pnf4\pnindent0{\pntxtb\''B7}}\fi-200\li200\fs20 Organize e encontre facilmente qualquer uma de suas anota\''e7\''f5es" +
      			@"\par {\pntext\f4\''B7\tab}Tenha uma forma r\''e1pida e f\''e1cil de criar uma anota\''e7\''e3o utilizando todas as vantagens de possuir um formato de texto RTF" +
		      	@"\par {\pntext\f4\''B7\tab}Tenha um editor de texto sempre a disposi\''e7\''e3o, acess\''edvel atrav\''e9s de uma tecla de atalho" +
		      	@"\par {\pntext\f4\''B7\tab}Pare de criar v\''e1rios arquivos texto (.txt) espalhados pelo seu disco r\''edgido ou pelo seu desktop!" +
		      	@"\par {\pntext\f4\''B7\tab}Use o MyNotesFree para gerenciar suas anota\''e7\''f5es." +
		      	@"\par \pard" +
		      	@"\par Sua versatilidade pode ser comprovada para situa\''e7\''f5es em que voc\''ea precisa copiar/salvar:" +
		      	@"\par \pard{\pntext\f4\''B7\tab}{\*\pn\pnlvlblt\pnf4\pnindent0{\pntxtb\''B7}}\fi-200\li200 Trechos de texto" +
		      	@"\par {\pntext\f4\''B7\tab}Arquivos importantes" +
		      	@"\par {\pntext\f4\''B7\tab}Print screens de textos que n\''e3o permitem c\''f3pia" +
		      	@"\par {\pntext\f4\''B7\tab}Uma \''e1rea r\''e1pida para transfer\''eancia de conte\''fado de v\''e1rias fontes diferentes" +
		      	@"\par \pard" +
		      	@"\par Algumas das caracter\''edsticas do MyNotesFree:" +
	      		@"\par \pard{\pntext\f4\''B7\tab}{\*\pn\pnlvlblt\pnf4\pnindent0{\pntxtb\''B7}}\fi-200\li200 Tecla de acesso r\''e1pida configur\''e1vel (CTRL + ALT + N)." +
		      	@"\par {\pntext\f4\''B7\tab}Editor de anota\''e7\''f5es r\''e1pidas - QuickNote - (CTRL + ALT + Q)." +
		      	@"\par {\pntext\f4\''B7\tab}Organiza\''e7\''e3o de anota\''e7\''f5es por assuntos (categorias)." +
		      	@"\par {\pntext\f4\''B7\tab}Exporta\''e7\''e3o de anota\''e7\''e3o para v\''e1rios formatos (txt, rtf e html)." +
		      	@"\par {\pntext\f4\''B7\tab}Filtragem das anota\''e7\''f5es por categoria." +
		      	@"\par {\pntext\f4\''B7\tab}Identifica\''e7\''e3o das categorias por cores." +
		      	@"\par {\pntext\f4\''B7\tab}Editor de textos vers\''e1til e que suporta o formato RTF (semelhante ao Word)." +
		      	@"\par {\pntext\f4\''B7\tab}Todas suas anota\''e7\''f5es s\''e3o armazenadas em um banco de dados, o que confere mais seguran\''e7a e simplicidade na manuten\''e7\''e3o de seus textos." +
		      	@"\par {\pntext\f4\''B7\tab}O banco de dados \''e9 o SQLite (\cf2\ul <http://www.sqlite.org>\cf1\ulnone ) - N\''e3o h\''e1 necessidade de instala\''e7\''e3o ou configura\''e7\''e3o de drivers adicionais." +
		      	@"\par \pard\f1" +
		      	@"\par \f2 Visite o nosso site para conhecer melhor o MyNotesFree (\cf2\ul <http://www.mynotes.vorkflov.com/>\cf1\ulnone )" +
		      	@"\par \pard\cf0\f3\fs16" +
		      	@"\par }";
  			note.CreatedAt = DateTime.Now;
  			note.UpdatedAt = DateTime.Now;
  			note.CategoryId = 1; //TODO: Vai ser sempre 1?
  			
  			AnnotationDAO noteDao = new AnnotationDAO();
  			noteDao.insert(note);
  			
  		}
  		
  		private static void insertDefaultCategories(SQLiteConnection conn, string description, string color, string font, int selected, int mustHide, int editable) {
  			var cmd = conn.CreateCommand();
  			cmd.CommandText = "insert into category (description, color, font, selected, mustHide, editable) values (@description, @color, @font, @selected, @mustHide, @editable)";
  			var pDescription = cmd.Parameters.Add("@description", DbType.String);
  			var pColor = cmd.Parameters.Add("@color", DbType.String);
  			var pFont = cmd.Parameters.Add("@font", DbType.String);
  			var pSelected = cmd.Parameters.Add("@selected", DbType.Int16);
  			var pMustHide = cmd.Parameters.Add("@mustHide", DbType.Int16);
  			var pEditable = cmd.Parameters.Add("@editable", DbType.Int16);
  			pDescription.Value = description;
  			pColor.Value = color;
  			pFont.Value = font;
  			pSelected.Value = selected;
  			pMustHide.Value = mustHide;
  			pEditable.Value = editable;
  			
  			cmd.ExecuteNonQuery();
  		}
  		
  		/**
  		 * Cria um SQLiteCommand para executar queries no DB
  		 */
  		public static SQLiteCommand getCommand(String sql) {
  			SQLiteCommand cmd = getConnection().CreateCommand();
  			cmd.CommandText = sql;
  			return cmd;
  		}
  		
  		/**
  		 * Retorna um DataReader de uma query
  		 */
  		public static SQLiteDataReader executeQuery(String sql) {
  			return getCommand(sql).ExecuteReader();
  		}
	}
}
