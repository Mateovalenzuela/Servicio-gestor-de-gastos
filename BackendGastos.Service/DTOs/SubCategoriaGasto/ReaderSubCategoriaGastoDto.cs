﻿namespace BackendGastos.Service.DTOs.SubCategoriaGasto
{
    public class ReaderSubCategoriaGastoDto
    {
        public long Id { get; set; }

        public string Descripcion { get; set; }

        public long CategoriaGastoId { get; set; }

        public long UsuarioId { get; set; }

        public DateTime FechaCreacion { get; set; }

        public bool Baja { get; set; }
    }
}
