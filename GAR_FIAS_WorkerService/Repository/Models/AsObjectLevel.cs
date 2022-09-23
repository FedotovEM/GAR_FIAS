using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_OBJECT_LEVELS")]
    public partial class AsObjectLevel
    {
        [Key]
        [Column("LEVEL")]
        public int Level { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(250)]
        [Unicode(false)]
        public string Name { get; set; }
        [Column("SHORTNAME")]
        [StringLength(50)]
        [Unicode(false)]
        public string Shortname { get; set; }
        [Column("UPDATEDATE", TypeName = "date")]
        public DateTime Updatedate { get; set; }
        [Column("STARTDATE", TypeName = "date")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "date")]
        public DateTime Enddate { get; set; }
        [Column("ISACTIVE")]
        public bool Isactive { get; set; }

        public static AsObjectLevel GetAttributeValue(XmlReader item)
        {
            AsObjectLevel asObjectLevel = new AsObjectLevel();

            item.MoveToAttribute("LEVEL");
            asObjectLevel.Level = int.Parse(item.Value);
            item.MoveToAttribute("NAME");
            asObjectLevel.Name = item.Value;

            if (item.MoveToAttribute("SHORTNAME"))
                asObjectLevel.Shortname = item.Value;
            else
                asObjectLevel.Shortname = null;

            item.MoveToAttribute("UPDATEDATE");
            asObjectLevel.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asObjectLevel.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asObjectLevel.Enddate = DateTime.Parse(item.Value);

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1" || IsactiveValue == "true")
                asObjectLevel.Isactive = true;
            else
                asObjectLevel.Isactive = false;

            return asObjectLevel;
        }
    }
}
