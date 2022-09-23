using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_ROOM_TYPES")]
    public partial class AsRoomType
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(100)]
        [Unicode(false)]
        public string Name { get; set; }
        [Column("SHORTNAME")]
        [StringLength(50)]
        [Unicode(false)]
        public string Shortname { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string Desk { get; set; }
        [Column("UPDATEDATE", TypeName = "date")]
        public DateTime Updatedate { get; set; }
        [Column("STARTDATE", TypeName = "date")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "date")]
        public DateTime Enddate { get; set; }
        [Column("ISACTIVE")]
        public bool Isactive { get; set; }

        public static AsRoomType GetAttributeValue(XmlReader item)
        {
            AsRoomType asRoomType = new AsRoomType();

            item.MoveToAttribute("ID");
            asRoomType.Id = int.Parse(item.Value);
            item.MoveToAttribute("NAME");
            asRoomType.Name = item.Value;

            if (item.MoveToAttribute("SHORTNAME"))
                asRoomType.Shortname = item.Value;
            else
                asRoomType.Shortname = null;

            if (item.MoveToAttribute("DESC"))
                asRoomType.Desk = item.Value;
            else
                asRoomType.Desk = null;

            item.MoveToAttribute("UPDATEDATE");
            asRoomType.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asRoomType.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asRoomType.Enddate = DateTime.Parse(item.Value);

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1" || IsactiveValue == "true")
                asRoomType.Isactive = true;
            else
                asRoomType.Isactive = false;

            return asRoomType;
        }
    }
}
