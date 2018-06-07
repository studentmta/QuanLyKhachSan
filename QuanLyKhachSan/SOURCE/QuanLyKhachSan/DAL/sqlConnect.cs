﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class sqlConnect
    {
        string strConn = @"Data Source=;Initial Catalog=QLKhachSan;Integrated Security=True";
        private SqlCommand cmd = null;
        private SqlConnection conn = null;

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        public sqlConnect()
        {
            conn = new SqlConnection(strConn);
        }

        public void openConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        public SqlDataReader getDataTable(string table)
        {
            SqlDataReader dr = null;
            string query = "select * from " + table;
            cmd = new SqlCommand(query, conn);
            this.openConnection();
            dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader execCommand(string sql)
        {
            SqlDataReader dr = null;
            try
            {
                this.openConnection();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                new Exception("Error:" + ex.Message);
            }
            return dr;
        }

        public void execNonQuery(string sql)
        {
            try
            {
                openConnection();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                new Exception("Error: " + ex.Message);
            }
        }
        public string execScanler(string sql)
        {
            string str = null;
            try
            {
                openConnection();
                cmd = new SqlCommand(sql, conn);
                str = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                new Exception("Error: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return str;
        }

        public DataTable TK(string cl)
        {
            openConnection();
            string query = cl;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dh = new SqlDataAdapter(cmd);
            DataTable dk = new DataTable();
            dh.Fill(dk);
            dh.Dispose();
            cmd.Dispose();
            return dk;
        }
    }
}
