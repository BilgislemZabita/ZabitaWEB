using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class Log : IEntity
    {
        [Key]
        public int LogID { get; set; }

        public DateTime LogTarih { get; set; }
        public string LogPersonel { get; set; }
        public string LogYapilanIs { get; set; }
        public string LogYapilanTur { get; set; }
    }
}