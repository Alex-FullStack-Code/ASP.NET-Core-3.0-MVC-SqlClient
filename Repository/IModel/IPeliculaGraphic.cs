﻿
using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using Cineplus_DSW_Proyecto.Models.ModelGraphic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface IPeliculaGraphic
    {
        #region Metodos para Implentar
        public IEnumerable<PeliculaGraphic> peliculasDatos();
        #endregion
    }
}
