﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using MySql.Data.MySqlClient;

namespace _20241122212117_databasing_again_and_again
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool manager { get; set; } = false;
    }

    public class UserRepo
    {
        MySqlConnection connection;
        public UserRepo(MySqlConnection connection)
        {
            this.connection = connection;
        }
        public void create(User user)
        {
            string query = $"INSERT INTO user (name, manager) VALUES ('{user.name}', {user.manager});";
            using (var command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public User read(int id)
        {
            string query = $"SELECT * FROM user WHERE id = {id};";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.id = reader.GetInt32(0);
                        user.name = reader.GetString(1);
                        user.manager = reader.GetBoolean(2);
                        return user;
                    }
                }
            }
            return null;
        }
        public void update(User user)
        {
            string query = $"UPDATE user SET name = '{user.name}', manager = {user.manager} WHERE id = {user.id};";
            using (var command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void delete(User user)
        {
            string query = $"DELETE FROM user WHERE id = {user.id};";
            using (var command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public class Listing
    {
        public int id { get; set; }
        public string name { get; set; }
        public uint price { get; set; }
        public string kind { get; set; }
        public User owner { get; set; }
    }

    public class ListingRepo
    {
        MySqlConnection connection;
        public ListingRepo(MySqlConnection connection)
        {
            this.connection = connection;
        }
        public void create(Listing listing)
        {
            string query = $"INSERT INTO listing (name, price, kind, owner) VALUES ('{listing.name}', {listing.price}, '{listing.kind}', {listing.owner.id});";
            using (var command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public Listing read(int id)
        {
            string query = $"SELECT * FROM listing WHERE id = {id};";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Listing listing = new Listing();
                        listing.id = reader.GetInt32(0);
                        listing.name = reader.GetString(1);
                        listing.price = reader.GetUInt32(2);
                        listing.kind = reader.GetString(3);
                        listing.owner = new UserRepo(connection).read(reader.GetInt32(4));
                        return listing;
                    }
                }
            }
            return null;
        }
        public void update(Listing listing)
        {
            string query = $"UPDATE listing SET name = '{listing.name}', price = {listing.price}, kind = '{listing.kind}', owner = {listing.owner.id} WHERE id = {listing.id};";
            using (var command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void delete(Listing listing)
        {
            string query = $"DELETE FROM listing WHERE id = {listing.id};";
            using (var command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public class Meeting
    {
        public int id { get; set; }
        public int score { get; set; }
        public string status { get; set; } = "Pending";
        public Listing viewable { get; set; }
        public User viewer { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            const string USER_NAME = "root";
            const string PASSWORD = "1313";
            const string HOST = "localhost";
            const string PORT = "3306";
            const string DATABASE_NAME = "fr_data";
            string connectionString = $"uid={USER_NAME};pwd={PASSWORD};host={HOST};port={PORT};database={DATABASE_NAME}";

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            UserRepo userRepo = new UserRepo(conn);
            // read all users 
            var userId = 1;
            var user = userRepo.read(userId);
            // show user id and name and status 
            Console.WriteLine($"User {user.id} {user.name} {user.manager}");
            while (user != null)
            {
                Console.WriteLine($"User {user.id} {user.name} {user.manager}");
                userId++;
                user = userRepo.read(userId);
            }

            Console.ReadKey();
        }
    }
}
