﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignApplication.Model
{
    public enum enumState
    {
        Upload = 1,
        Edit = 2,
        ReadyToSend = 3,
        Sent = 4
    }

    [Table("SystemListValue")]
    public class SystemListValue
    {
        public SystemListValue()
        {
           
        }

        [Key]
        [Column("ID", TypeName = "int")]
        public int ID { get; set; }

        [ForeignKey("SystemList")]
        [Column("SystemListID", TypeName = "int")]
        public int SystemListID { get; set; }

        public virtual SystemList SystemList { get; set; }

        [Column("Title", TypeName = "varchar")]
        [MaxLength(250)]
        public string Title { get; set; }

    }
}