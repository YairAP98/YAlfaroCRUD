﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class YAlfaroCRUDEntities : DbContext
    {
        public YAlfaroCRUDEntities()
            : base("name=YAlfaroCRUDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Disco> Discoes { get; set; }
    
        public virtual ObjectResult<GetAllDisco_Result> GetAllDisco()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllDisco_Result>("GetAllDisco");
        }
    
        public virtual int AddDisco(string titulo, string artista, string generoMusical, Nullable<System.TimeSpan> duracion, Nullable<int> año, string distribuidora, Nullable<int> ventas, Nullable<int> disponibilidad)
        {
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var artistaParameter = artista != null ?
                new ObjectParameter("Artista", artista) :
                new ObjectParameter("Artista", typeof(string));
    
            var generoMusicalParameter = generoMusical != null ?
                new ObjectParameter("GeneroMusical", generoMusical) :
                new ObjectParameter("GeneroMusical", typeof(string));
    
            var duracionParameter = duracion.HasValue ?
                new ObjectParameter("Duracion", duracion) :
                new ObjectParameter("Duracion", typeof(System.TimeSpan));
    
            var añoParameter = año.HasValue ?
                new ObjectParameter("Año", año) :
                new ObjectParameter("Año", typeof(int));
    
            var distribuidoraParameter = distribuidora != null ?
                new ObjectParameter("Distribuidora", distribuidora) :
                new ObjectParameter("Distribuidora", typeof(string));
    
            var ventasParameter = ventas.HasValue ?
                new ObjectParameter("Ventas", ventas) :
                new ObjectParameter("Ventas", typeof(int));
    
            var disponibilidadParameter = disponibilidad.HasValue ?
                new ObjectParameter("Disponibilidad", disponibilidad) :
                new ObjectParameter("Disponibilidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddDisco", tituloParameter, artistaParameter, generoMusicalParameter, duracionParameter, añoParameter, distribuidoraParameter, ventasParameter, disponibilidadParameter);
        }
    
        public virtual int DeleteDisco(Nullable<int> idDisco)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteDisco", idDiscoParameter);
        }
    
        public virtual ObjectResult<GetByIdDisco_Result> GetByIdDisco(Nullable<int> idDisco)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByIdDisco_Result>("GetByIdDisco", idDiscoParameter);
        }
    
        public virtual int UpdateDisco(Nullable<int> idDisco, string titulo, string artista, string generoMusical, Nullable<System.TimeSpan> duracion, Nullable<int> año, string distribuidora, Nullable<int> ventas, Nullable<int> disponibilidad)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var artistaParameter = artista != null ?
                new ObjectParameter("Artista", artista) :
                new ObjectParameter("Artista", typeof(string));
    
            var generoMusicalParameter = generoMusical != null ?
                new ObjectParameter("GeneroMusical", generoMusical) :
                new ObjectParameter("GeneroMusical", typeof(string));
    
            var duracionParameter = duracion.HasValue ?
                new ObjectParameter("Duracion", duracion) :
                new ObjectParameter("Duracion", typeof(System.TimeSpan));
    
            var añoParameter = año.HasValue ?
                new ObjectParameter("Año", año) :
                new ObjectParameter("Año", typeof(int));
    
            var distribuidoraParameter = distribuidora != null ?
                new ObjectParameter("Distribuidora", distribuidora) :
                new ObjectParameter("Distribuidora", typeof(string));
    
            var ventasParameter = ventas.HasValue ?
                new ObjectParameter("Ventas", ventas) :
                new ObjectParameter("Ventas", typeof(int));
    
            var disponibilidadParameter = disponibilidad.HasValue ?
                new ObjectParameter("Disponibilidad", disponibilidad) :
                new ObjectParameter("Disponibilidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateDisco", idDiscoParameter, tituloParameter, artistaParameter, generoMusicalParameter, duracionParameter, añoParameter, distribuidoraParameter, ventasParameter, disponibilidadParameter);
        }
    }
}
