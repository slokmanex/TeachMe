﻿using System.ComponentModel.DataAnnotations;
using Repository;

namespace BooksDataLayer.Entities
{
    public class Student : IHaveId
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string EncryptedPassword { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public Parent Parent { get; set; }
        public int ParentId { get; set; }
    }
}