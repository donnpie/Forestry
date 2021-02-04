using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ForestryLibrary.DbHandler
{
    public interface IDbHandler
    {
        SqlConnection Connection { get; }

        SqlCommand Command { get; }

        SqlDataReader Reader { get; }

        /// <summary>
        /// Build the query based on value of QType
        /// </summary>
        void BuildQuery();

        /// <summary>
        /// For queries with one parameter, where the parameter is an int
        /// </summary>
        /// <param name="searchKey"></param>
        void BuildQuery(int searchKey);

        /// <summary>
        /// Opens the database connection
        /// </summary>
        void Open();

        /// <summary>
        /// Opens the connection, executes the reader, updates ForestObject and closes the connection
        /// </summary>
        void SqlGetReader();

        /// <summary>
        /// Updates the forest object depending the value of QueryType.
        /// Is called from inside SqlGetReader
        /// </summary>
        void UpdateForestObject();

        /// <summary>
        /// Closes the database connection
        /// Connection has to remain open until reader has finished reading
        /// </summary>
        void Close();

    }
}
