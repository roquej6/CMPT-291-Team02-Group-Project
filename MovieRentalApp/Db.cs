using System;
using System.Data;
using Microsoft.Data.SqlClient;
namespace MovieRentalApp;
static class Db
{
    // Copy the server name from the SSMS "Connect to Server" box.
    public const string ConnString = 
        @"Server=localhost;Database=MovieRental_Team02;"+
        @"Trusted_Connection=True;TrustServerCertificate=True;";

    // SELECT: returns the rows as a DataTable (for grids and drop-downs).
    public static DataTable Query(string sql, params SqlParameter[] ps)
    {
        using var conn = new SqlConnection(ConnString);
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddRange(ps);
        var table = new DataTable();
        using var adapter = new SqlDataAdapter(cmd);
        adapter.Fill(table); // opens, reads everything, closes
        return table;
    }
    // INSERT, UPDATE, DELETE: returns the number of rows changed.
    public static int Execute(string sql, params SqlParameter[] ps)
    {
        using var conn = new SqlConnection(ConnString);
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddRange(ps);
        conn.Open();
        return cmd.ExecuteNonQuery();
    }
    // One value, such as COUNT(*).
    public static object Scalar(string sql, params SqlParameter[] ps)
    {
        using var conn = new SqlConnection(ConnString);
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddRange(ps);
        conn.Open();
        return cmd.ExecuteScalar();
    }
    // Short way to make a typed parameter: Db.P("@id", SqlDbType.VarChar, 5, id)
    public static SqlParameter P(string name, SqlDbType type, int size, object value)
    => new SqlParameter(name, type, size) { Value = value };
}
