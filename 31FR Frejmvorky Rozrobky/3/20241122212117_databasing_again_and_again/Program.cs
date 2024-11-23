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
            string id_query = $"SELECT LAST_INSERT_ID();";
            using (var command = new MySqlCommand(id_query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user.id = reader.GetInt32(0);
                    }
                }
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
            string id_query = $"SELECT LAST_INSERT_ID();";
            using (var command = new MySqlCommand(id_query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listing.id = reader.GetInt32(0);
                    }
                }
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

    public class MeetingRepo
    {
        MySqlConnection connection;
        public MeetingRepo(MySqlConnection connection)
        {
            this.connection = connection;
        }
        public void create(Meeting meeting)
        {
            string query = $"INSERT INTO meeting (score, status, viewable, viewer) VALUES ({meeting.score}, '{meeting.status}', {meeting.viewable.id}, {meeting.viewer.id});";
            using (var command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
            string id_query = $"SELECT LAST_INSERT_ID();";
            using (var command = new MySqlCommand(id_query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        meeting.id = reader.GetInt32(0);
                    }
                }
            }
        }
        public Meeting read(int id)
        {
            string query = $"SELECT * FROM meeting WHERE id = {id};";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Meeting meeting = new Meeting();
                        meeting.id = reader.GetInt32(0);
                        meeting.score = reader.GetInt32(1);
                        meeting.status = reader.GetString(2);
                        meeting.viewable = new ListingRepo(connection).read(reader.GetInt32(3));
                        meeting.viewer = new UserRepo(connection).read(reader.GetInt32(4));
                        return meeting;
                    }
                }
            }
            return null;
        }
        public void update(Meeting meeting)
        {
            string query = $"UPDATE meeting SET score = {meeting.score}, status = '{meeting.status}', viewable = {meeting.viewable.id}, viewer = {meeting.viewer.id} WHERE id = {meeting.id};";
            using (var command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void delete(Meeting meeting)
        {
            string query = $"DELETE FROM meeting WHERE id = {meeting.id};";
            using (var command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public class Program
    {
        static void testUser(MySqlConnection conn)
        {
            conn.Open();
            UserRepo userRepo = new UserRepo(conn);

            // Create
            User user = new User();
            user.name = "John Doe";
            user.manager = false;
            userRepo.create(user);

            // Read
            user = userRepo.read(user.id);
            Console.WriteLine($"Created user with id {user.id} and name {user.name} and manager {user.manager}");

            // Update
            user.manager = true;
            userRepo.update(user);
            user = userRepo.read(user.id);
            Console.WriteLine($"Updated user with id {user.id} and name {user.name} and manager {user.manager}");

            // Delete
            userRepo.delete(user);

            conn.Close();
        }

        static void testListing(MySqlConnection conn)
        {
            conn.Open();
            ListingRepo listingRepo = new ListingRepo(conn);

            // Create
            Listing listing = new Listing();
            listing.name = "Test Listing";
            listing.price = 120;
            listing.kind = "New";
            listing.owner = new UserRepo(conn).read(1);
            listingRepo.create(listing);

            // Read
            listing = listingRepo.read(listing.id);
            Console.WriteLine($"Created listing with id {listing.id} and name {listing.name} and price {listing.price} and kind {listing.kind} and owner {listing.owner.name}");

            // Update
            listing.price = 150;
            listing.kind = "Flat";
            listingRepo.update(listing);
            listing = listingRepo.read(listing.id);
            Console.WriteLine($"Updated listing with id {listing.id} and name {listing.name} and price {listing.price} and kind {listing.kind} and owner {listing.owner.name}");

            // Delete
            listingRepo.delete(listing);

            conn.Close();
        }

        static void Main(string[] args)
        {
            const string USER_NAME = "root";
            const string PASSWORD = "1313";
            const string HOST = "localhost";
            const string PORT = "3306";
            const string DATABASE_NAME = "fr_data";
            string connectionString = $"uid={USER_NAME};pwd={PASSWORD};host={HOST};port={PORT};database={DATABASE_NAME}";

            MySqlConnection userConn = new MySqlConnection(connectionString);
            testUser(userConn);
            MySqlConnection listingConn = new MySqlConnection(connectionString);
            testListing(listingConn);

            Console.ReadKey();
        }
    }
}
