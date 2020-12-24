using System;
using System.ComponentModel.DataAnnotations;

namespace Leantek.Gateway.Model
{
    public class DatabaseObject
    {
        [Key]
        public string Id { get; set; }
    }
}