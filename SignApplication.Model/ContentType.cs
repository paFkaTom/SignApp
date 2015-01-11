﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignApplication.Model
{
    [Table("ContentType")]
    public class ContentType
    {
        public ContentType() 
        {
        }

        [Key]
        [Column("ID", TypeName = "int")]
        public int ID { get; set; }

        [Column("Title", TypeName = "varchar")]
        [MaxLength(250)]
        public string Title { get; set; }

        [Column("Class", TypeName = "varchar")]
        [MaxLength(250)]
        public string Class { get; set; }

        [Column("Del_fl", TypeName = "bit")]
        public bool IsDelete { get; set; }

        [Column("DefaultWidth", TypeName = "float")]
        public float DefaultWidth { get; set; }

        [Column("DefaultHeight", TypeName = "float")]
        public float DefaultHeight { get; set; }

        [Column("DefaultValue", TypeName = "varchar")]
        [MaxLength(1000)]
        public string DefaultValue { get; set; }
    }
}