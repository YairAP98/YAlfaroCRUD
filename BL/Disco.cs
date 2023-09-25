using ML;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Disco
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.YAlfaroCRUDEntities context = new DL.YAlfaroCRUDEntities())
                {

                    var filasAf = context.GetAllDisco();
                    result.Objects = new List<object>();
                    if (filasAf != null)
                    {
                        foreach (var fi in filasAf)
                        {
                            ML.Disco discoObj = new ML.Disco();
                            discoObj.IdDisco = fi.IdDisco;
                            discoObj.Titulo = fi.Titulo;
                            discoObj.Artista = fi.Artista;
                            discoObj.GeneroMusical = fi.GeneroMusical;
                            discoObj.Duracion = TimeSpan.Parse(fi.Duracion.ToString());
                            discoObj.Año = int.Parse(fi.Año.ToString());
                            discoObj.Distribuidora = fi.Distribuidora;
                            discoObj.Ventas = int.Parse(fi.Ventas.ToString());
                            discoObj.Disponibilidad = int.Parse(fi.Disponibilidad.ToString());
                            result.Objects.Add(discoObj);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No hay discos que mostrar";
                    }

                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }

            return result;
        }
        public static ML.Result GetById(int IdDisco)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.YAlfaroCRUDEntities context = new DL.YAlfaroCRUDEntities())
                {

                    var filasAf = context.GetByIdDisco(IdDisco);
                    result.Objects = new List<object>();
                    if (filasAf != null)
                    {
                        foreach (var fi in filasAf)
                        {
                            ML.Disco discoObj = new ML.Disco();
                            discoObj.IdDisco = fi.IdDisco;
                            discoObj.Titulo = fi.Titulo;
                            discoObj.Artista = fi.Artista;
                            discoObj.GeneroMusical = fi.GeneroMusical;
                            discoObj.Duracion = TimeSpan.Parse(fi.Duracion.ToString());
                            discoObj.Año = int.Parse(fi.Año.ToString());
                            discoObj.Distribuidora = fi.Distribuidora;
                            discoObj.Ventas = int.Parse(fi.Ventas.ToString());
                            discoObj.Disponibilidad = int.Parse(fi.Disponibilidad.ToString());
                            result.Objects.Add(discoObj);
                        }
                        result.Correct = true;
                    }


                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }

            return result;
        }
        public static ML.Result Add(ML.Disco disco)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.YAlfaroCRUDEntities context = new DL.YAlfaroCRUDEntities())
                {

                    ObjectParameter filasAf = new ObjectParameter("FilasAf", typeof(int));

                    var query = context.AddDisco(
                        disco.Titulo,
                        disco.Artista,
                        disco.GeneroMusical,
                        disco.Duracion,
                        disco.Año,
                        disco.Distribuidora,
                        disco.Ventas,
                        disco.Disponibilidad                    
                        
                        );
                    if (query >=1)
                    {
                        result.Correct= true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Disco no agregado";
                    }

                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }

            return result;
        }
        public static ML.Result Update(ML.Disco disco)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.YAlfaroCRUDEntities context = new DL.YAlfaroCRUDEntities())
                {

                    ObjectParameter filasAf = new ObjectParameter("FilasAf", typeof(int));

                    var query = context.UpdateDisco(
                        disco.IdDisco,
                        disco.Titulo,
                        disco.Artista,
                        disco.GeneroMusical,
                        disco.Duracion,
                        disco.Año,
                        disco.Distribuidora,
                        disco.Ventas,
                        disco.Disponibilidad

                        );
                    if ((int)filasAf.Value == 2)
                    {
                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Disco no actualizado";
                    }

                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }

            return result;
        }

        public static ML.Result DeleteEF(int IdDisco)
        {
            ML.Result resultado = new ML.Result();
            try
            {
                using (DL.YAlfaroCRUDEntities context = new DL.YAlfaroCRUDEntities())
                {
                    var query = context.DeleteDisco(IdDisco);
                    if (query > 0)
                    //if (filasAfectadas>0)
                    {
                        resultado.Correct = true;
                    }
                    else
                    {
                        resultado.Correct = false;
                        resultado.ErrorMessage = "Usuario no eliminado";
                    }
                }
            }
            catch (Exception ex)
            {

                resultado.Correct = false;
                resultado.ErrorMessage = ex.Message;
                resultado.Ex = ex;
            }
            return resultado;
        }
    }
}
