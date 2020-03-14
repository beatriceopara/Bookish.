using System;
using System.Linq;
using Bookish1.Models;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using MySql.Data.MySqlClient;


namespace Bookish1.Controllers
{
    
    public class SearchController:Controller
    {
        [Route("search")]
        public IActionResult Search()
        {
            return View("Search");
        }

        [HttpPost("/results")]

        public IActionResult SearchResults()
        {
            var connectionString = "Server=localhost;Database=library;Uid=root;Pwd=sugar;";
            using var connection = new MySqlConnection(connectionString);

            var searchResults = connection.Query<SearchModel>("SELECT * FROM library.books WHERE authorLastName = 'Rowling'").ToList();
            
            searchResults.ForEach(Console.Write);

            return View(searchResults);
        }
        
    }

}