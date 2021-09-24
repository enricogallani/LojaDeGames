﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaDeGames.Repositório
{
    public class Conexão
    {
        // GET: Conexão
        MySqlConnection cn = new MySqlConnection("Server=localhost;DataBase=db_loja;user=root;pwd=enrico1803");
        public static string msg;

        public MySqlConnection ConectarBD()
        {
            try
            {
                cn.Open();
            }
            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao conectar com o banco." + erro.Message;
            }
            return cn;
        }
        public MySqlConnection DesconectarBD()
        {
            try
            {
                cn.Close();
            }
            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao desconectar com o banco." + erro.Message;
            }
            return cn;

        }


    }
}