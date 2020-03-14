using System;
using System.Linq;
using Bookish1.Models;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using MySql.Data.MySqlClient;

namespace Bookish1.Controllers
{
    public class AddBookController:Controller
    {
        [Route("add-book")]
        public IActionResult AddBook()
        {
            var connectionString = "Server=localhost;Database=library;Uid=root;Pwd=sugar;";
            using var connection = new MySqlConnection(connectionString);
            
            
            return View("AddBook");
        }
    }
}