﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQLivros.Models.TabModels
{
    [MetadataType(typeof(TabExemplarMetadata))]
    public partial class TabExemplar
    {
        public bool IsDisponivel()
        {
            if (this.dsStatus.Equals((int)StatusRegistroExemplar.DISPONIVEL))
            {
                return true;
            }
            return false;
        }
    }

    public class TabExemplarMetadata
    {

    }

    public enum StatusRegistroExemplar
    {
        DISPONIVEL = 1,
        INDISPONIVEL,
        INATIVO
    }
}
