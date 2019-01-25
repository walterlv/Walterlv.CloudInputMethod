﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Walterlv.CloudTyping.Models
{
    public class Keyboard
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Uid { get; set; }

        public virtual List<KeyboardTyping> Typings { get; set; }
    }
}