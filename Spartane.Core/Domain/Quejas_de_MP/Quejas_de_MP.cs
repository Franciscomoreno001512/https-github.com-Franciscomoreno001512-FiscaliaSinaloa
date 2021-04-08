using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Estatus_Quejas_MP;
using Spartane.Core.Domain.Forma_Cara;
using Spartane.Core.Domain.Cejas;
using Spartane.Core.Domain.Tamano_de_Cejas;
using Spartane.Core.Domain.Largo_de_Cabello;
using Spartane.Core.Domain.Cantidad_Cabello;
using Spartane.Core.Domain.Implantacion_Cabello;
using Spartane.Core.Domain.Complexion;
using Spartane.Core.Domain.Color_Piel;
using Spartane.Core.Domain.Frente;
using Spartane.Core.Domain.Forma_Cabello;
using Spartane.Core.Domain.Color_de_Cabello;
using Spartane.Core.Domain.Calvicie;
using Spartane.Core.Domain.Color_Ojos;
using Spartane.Core.Domain.Ojos;
using Spartane.Core.Domain.Forma_Ojos;
using Spartane.Core.Domain.Anteojos;
using Spartane.Core.Domain.Forma_de_Nariz;
using Spartane.Core.Domain.Nariz_Base;
using Spartane.Core.Domain.Labios;
using Spartane.Core.Domain.Boca;
using Spartane.Core.Domain.Grosor_de_Labios;
using Spartane.Core.Domain.Menton;
using Spartane.Core.Domain.Forma_de_Menton;
using Spartane.Core.Domain.Barba;
using Spartane.Core.Domain.Forma_Orejas;
using Spartane.Core.Domain.Tamano_Orejas;
using Spartane.Core.Domain.Tipo_Lobulo;
using Spartane.Core.Domain.Bigote;
using Spartane.Core.Domain.Senas_Particulares;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Domain.Situacion_Fisica;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Quejas_de_MP
{
    /// <summary>
    /// Quejas_de_MP table
    /// </summary>
    public class Quejas_de_MP: BaseEntity
    {
        public int Clave { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public string Correo_Electronico { get; set; }
        public string Celular { get; set; }
        public int? Estatus { get; set; }
        public string Peso { get; set; }
        public string Estatura { get; set; }
        public string Padecimiento_de_Enfermedad { get; set; }
        public int? Forma_Cara { get; set; }
        public int? Tipo_de_Cejas { get; set; }
        public int? Tamano_de_Cejas { get; set; }
        public int? Largo_de_Cabello { get; set; }
        public int? Cantidad_Cabello { get; set; }
        public int? Implantacion_Cabello { get; set; }
        public int? Complexion { get; set; }
        public int? Color_Piel { get; set; }
        public int? Frente { get; set; }
        public int? Forma_Cabello { get; set; }
        public int? Color_Cabello { get; set; }
        public int? Calvicie { get; set; }
        public int? Color_Ojos { get; set; }
        public int? Tamano_de_Ojos { get; set; }
        public int? Forma_Ojos { get; set; }
        public int? Anteojos { get; set; }
        public int? Forma_de_Nariz { get; set; }
        public int? Tamano_Nariz { get; set; }
        public int? Labios { get; set; }
        public int? Boca { get; set; }
        public int? Grosor_de_Labios { get; set; }
        public int? Menton { get; set; }
        public int? Forma_de_Menton { get; set; }
        public int? Barba { get; set; }
        public int? Forma_Orejas { get; set; }
        public int? Tamano_Orejas { get; set; }
        public int? Tipo_Lobulo { get; set; }
        public int? Bigote { get; set; }
        public int? Senas_Particulares { get; set; }
        public int? Imagen_Tatuaje { get; set; }
        public string Imagen_Tatuaje_URL { get; set; }
        public int? Situacion_Fisica { get; set; }
        public string Otras_Senas_Particulares { get; set; }
        public string Descripcion_de_los_Hechos { get; set; }
        public DateTime? Fecha_de_los_Hechos { get; set; }
        public string Hora_de_los_Hechos { get; set; }
        public int? Municipio_hechos { get; set; }
        public int? Poblacion_hechos { get; set; }
        public int? Colonia_hechos { get; set; }
        public string Calle_hechos { get; set; }
        public string Entre_Calle_hechos { get; set; }
        public string Y_Calle_hechos { get; set; }
        public string Numero_Exterior_hechos { get; set; }
        public string Numero_Interior_hechos { get; set; }
        public int? Codigo_Postal_hechos { get; set; }
        public string Referencia { get; set; }
        public string CURP_Identificacion { get; set; }
        public string Nombres_Identificacion { get; set; }
        public string Apellido_Paterno_Identificacion { get; set; }
        public string Apellido_Materno_Identificacion { get; set; }
        public string Alias { get; set; }
        public DateTime? Fecha_Nacimiento_Identificacion { get; set; }
        public int? Edad_Identificacion { get; set; }
        public int? Genero_Identificacion { get; set; }
        public string Celular_Identificacion { get; set; }
        public string Correo_Identificacion { get; set; }
        public int? Tipo_de_Identificacion_Identificacion { get; set; }
        public string Numero_Identificacion_Identificacion { get; set; }
        public int? Nacionalidad_Identificacion { get; set; }
        public int? Entidad_de_Nacimiento_Identificacion { get; set; }
        public int? Municipio { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia { get; set; }
        public string Calle { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Codigo_Postal { get; set; }
        public string Referencias_de_domicilio { get; set; }

        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_Quejas_MP.Estatus_Quejas_MP Estatus_Estatus_Quejas_MP { get; set; }
        [ForeignKey("Forma_Cara")]
        public virtual Spartane.Core.Domain.Forma_Cara.Forma_Cara Forma_Cara_Forma_Cara { get; set; }
        [ForeignKey("Tipo_de_Cejas")]
        public virtual Spartane.Core.Domain.Cejas.Cejas Tipo_de_Cejas_Cejas { get; set; }
        [ForeignKey("Tamano_de_Cejas")]
        public virtual Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas Tamano_de_Cejas_Tamano_de_Cejas { get; set; }
        [ForeignKey("Largo_de_Cabello")]
        public virtual Spartane.Core.Domain.Largo_de_Cabello.Largo_de_Cabello Largo_de_Cabello_Largo_de_Cabello { get; set; }
        [ForeignKey("Cantidad_Cabello")]
        public virtual Spartane.Core.Domain.Cantidad_Cabello.Cantidad_Cabello Cantidad_Cabello_Cantidad_Cabello { get; set; }
        [ForeignKey("Implantacion_Cabello")]
        public virtual Spartane.Core.Domain.Implantacion_Cabello.Implantacion_Cabello Implantacion_Cabello_Implantacion_Cabello { get; set; }
        [ForeignKey("Complexion")]
        public virtual Spartane.Core.Domain.Complexion.Complexion Complexion_Complexion { get; set; }
        [ForeignKey("Color_Piel")]
        public virtual Spartane.Core.Domain.Color_Piel.Color_Piel Color_Piel_Color_Piel { get; set; }
        [ForeignKey("Frente")]
        public virtual Spartane.Core.Domain.Frente.Frente Frente_Frente { get; set; }
        [ForeignKey("Forma_Cabello")]
        public virtual Spartane.Core.Domain.Forma_Cabello.Forma_Cabello Forma_Cabello_Forma_Cabello { get; set; }
        [ForeignKey("Color_Cabello")]
        public virtual Spartane.Core.Domain.Color_de_Cabello.Color_de_Cabello Color_Cabello_Color_de_Cabello { get; set; }
        [ForeignKey("Calvicie")]
        public virtual Spartane.Core.Domain.Calvicie.Calvicie Calvicie_Calvicie { get; set; }
        [ForeignKey("Color_Ojos")]
        public virtual Spartane.Core.Domain.Color_Ojos.Color_Ojos Color_Ojos_Color_Ojos { get; set; }
        [ForeignKey("Tamano_de_Ojos")]
        public virtual Spartane.Core.Domain.Ojos.Ojos Tamano_de_Ojos_Ojos { get; set; }
        [ForeignKey("Forma_Ojos")]
        public virtual Spartane.Core.Domain.Forma_Ojos.Forma_Ojos Forma_Ojos_Forma_Ojos { get; set; }
        [ForeignKey("Anteojos")]
        public virtual Spartane.Core.Domain.Anteojos.Anteojos Anteojos_Anteojos { get; set; }
        [ForeignKey("Forma_de_Nariz")]
        public virtual Spartane.Core.Domain.Forma_de_Nariz.Forma_de_Nariz Forma_de_Nariz_Forma_de_Nariz { get; set; }
        [ForeignKey("Tamano_Nariz")]
        public virtual Spartane.Core.Domain.Nariz_Base.Nariz_Base Tamano_Nariz_Nariz_Base { get; set; }
        [ForeignKey("Labios")]
        public virtual Spartane.Core.Domain.Labios.Labios Labios_Labios { get; set; }
        [ForeignKey("Boca")]
        public virtual Spartane.Core.Domain.Boca.Boca Boca_Boca { get; set; }
        [ForeignKey("Grosor_de_Labios")]
        public virtual Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios Grosor_de_Labios_Grosor_de_Labios { get; set; }
        [ForeignKey("Menton")]
        public virtual Spartane.Core.Domain.Menton.Menton Menton_Menton { get; set; }
        [ForeignKey("Forma_de_Menton")]
        public virtual Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton Forma_de_Menton_Forma_de_Menton { get; set; }
        [ForeignKey("Barba")]
        public virtual Spartane.Core.Domain.Barba.Barba Barba_Barba { get; set; }
        [ForeignKey("Forma_Orejas")]
        public virtual Spartane.Core.Domain.Forma_Orejas.Forma_Orejas Forma_Orejas_Forma_Orejas { get; set; }
        [ForeignKey("Tamano_Orejas")]
        public virtual Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas Tamano_Orejas_Tamano_Orejas { get; set; }
        [ForeignKey("Tipo_Lobulo")]
        public virtual Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo Tipo_Lobulo_Tipo_Lobulo { get; set; }
        [ForeignKey("Bigote")]
        public virtual Spartane.Core.Domain.Bigote.Bigote Bigote_Bigote { get; set; }
        [ForeignKey("Senas_Particulares")]
        public virtual Spartane.Core.Domain.Senas_Particulares.Senas_Particulares Senas_Particulares_Senas_Particulares { get; set; }
        [ForeignKey("Imagen_Tatuaje")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Imagen_Tatuaje_Spartane_File { get; set; }
        [ForeignKey("Situacion_Fisica")]
        public virtual Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica Situacion_Fisica_Situacion_Fisica { get; set; }
        [ForeignKey("Municipio_hechos")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_hechos_Municipio { get; set; }
        [ForeignKey("Poblacion_hechos")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_hechos_Colonia { get; set; }
        [ForeignKey("Colonia_hechos")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_hechos_Colonia { get; set; }
        [ForeignKey("Genero_Identificacion")]
        public virtual Spartane.Core.Domain.Genero.Genero Genero_Identificacion_Genero { get; set; }
        [ForeignKey("Tipo_de_Identificacion_Identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Identificacion_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Nacionalidad_Identificacion")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_Identificacion_Nacionalidad { get; set; }
        [ForeignKey("Entidad_de_Nacimiento_Identificacion")]
        public virtual Spartane.Core.Domain.Estado.Estado Entidad_de_Nacimiento_Identificacion_Estado { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }

    }
	
	public class Quejas_de_MP_Datos_Generales
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public string Correo_Electronico { get; set; }
        public string Celular { get; set; }
        public int? Estatus { get; set; }

		        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_Quejas_MP.Estatus_Quejas_MP Estatus_Estatus_Quejas_MP { get; set; }

    }

	public class Quejas_de_MP_Rasgos_Fisicos
    {
                public int Clave { get; set; }
        public string Peso { get; set; }
        public string Estatura { get; set; }
        public string Padecimiento_de_Enfermedad { get; set; }
        public int? Forma_Cara { get; set; }
        public int? Tipo_de_Cejas { get; set; }
        public int? Tamano_de_Cejas { get; set; }
        public int? Largo_de_Cabello { get; set; }
        public int? Cantidad_Cabello { get; set; }
        public int? Implantacion_Cabello { get; set; }
        public int? Complexion { get; set; }
        public int? Color_Piel { get; set; }
        public int? Frente { get; set; }
        public int? Forma_Cabello { get; set; }
        public int? Color_Cabello { get; set; }
        public int? Calvicie { get; set; }
        public int? Color_Ojos { get; set; }
        public int? Tamano_de_Ojos { get; set; }
        public int? Forma_Ojos { get; set; }
        public int? Anteojos { get; set; }
        public int? Forma_de_Nariz { get; set; }
        public int? Tamano_Nariz { get; set; }
        public int? Labios { get; set; }
        public int? Boca { get; set; }
        public int? Grosor_de_Labios { get; set; }
        public int? Menton { get; set; }
        public int? Forma_de_Menton { get; set; }
        public int? Barba { get; set; }
        public int? Forma_Orejas { get; set; }
        public int? Tamano_Orejas { get; set; }
        public int? Tipo_Lobulo { get; set; }
        public int? Bigote { get; set; }
        public int? Senas_Particulares { get; set; }
        public int? Imagen_Tatuaje { get; set; }
        public string Imagen_Tatuaje_URL { get; set; }
        public int? Situacion_Fisica { get; set; }
        public string Otras_Senas_Particulares { get; set; }

		        [ForeignKey("Forma_Cara")]
        public virtual Spartane.Core.Domain.Forma_Cara.Forma_Cara Forma_Cara_Forma_Cara { get; set; }
        [ForeignKey("Tipo_de_Cejas")]
        public virtual Spartane.Core.Domain.Cejas.Cejas Tipo_de_Cejas_Cejas { get; set; }
        [ForeignKey("Tamano_de_Cejas")]
        public virtual Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas Tamano_de_Cejas_Tamano_de_Cejas { get; set; }
        [ForeignKey("Largo_de_Cabello")]
        public virtual Spartane.Core.Domain.Largo_de_Cabello.Largo_de_Cabello Largo_de_Cabello_Largo_de_Cabello { get; set; }
        [ForeignKey("Cantidad_Cabello")]
        public virtual Spartane.Core.Domain.Cantidad_Cabello.Cantidad_Cabello Cantidad_Cabello_Cantidad_Cabello { get; set; }
        [ForeignKey("Implantacion_Cabello")]
        public virtual Spartane.Core.Domain.Implantacion_Cabello.Implantacion_Cabello Implantacion_Cabello_Implantacion_Cabello { get; set; }
        [ForeignKey("Complexion")]
        public virtual Spartane.Core.Domain.Complexion.Complexion Complexion_Complexion { get; set; }
        [ForeignKey("Color_Piel")]
        public virtual Spartane.Core.Domain.Color_Piel.Color_Piel Color_Piel_Color_Piel { get; set; }
        [ForeignKey("Frente")]
        public virtual Spartane.Core.Domain.Frente.Frente Frente_Frente { get; set; }
        [ForeignKey("Forma_Cabello")]
        public virtual Spartane.Core.Domain.Forma_Cabello.Forma_Cabello Forma_Cabello_Forma_Cabello { get; set; }
        [ForeignKey("Color_Cabello")]
        public virtual Spartane.Core.Domain.Color_de_Cabello.Color_de_Cabello Color_Cabello_Color_de_Cabello { get; set; }
        [ForeignKey("Calvicie")]
        public virtual Spartane.Core.Domain.Calvicie.Calvicie Calvicie_Calvicie { get; set; }
        [ForeignKey("Color_Ojos")]
        public virtual Spartane.Core.Domain.Color_Ojos.Color_Ojos Color_Ojos_Color_Ojos { get; set; }
        [ForeignKey("Tamano_de_Ojos")]
        public virtual Spartane.Core.Domain.Ojos.Ojos Tamano_de_Ojos_Ojos { get; set; }
        [ForeignKey("Forma_Ojos")]
        public virtual Spartane.Core.Domain.Forma_Ojos.Forma_Ojos Forma_Ojos_Forma_Ojos { get; set; }
        [ForeignKey("Anteojos")]
        public virtual Spartane.Core.Domain.Anteojos.Anteojos Anteojos_Anteojos { get; set; }
        [ForeignKey("Forma_de_Nariz")]
        public virtual Spartane.Core.Domain.Forma_de_Nariz.Forma_de_Nariz Forma_de_Nariz_Forma_de_Nariz { get; set; }
        [ForeignKey("Tamano_Nariz")]
        public virtual Spartane.Core.Domain.Nariz_Base.Nariz_Base Tamano_Nariz_Nariz_Base { get; set; }
        [ForeignKey("Labios")]
        public virtual Spartane.Core.Domain.Labios.Labios Labios_Labios { get; set; }
        [ForeignKey("Boca")]
        public virtual Spartane.Core.Domain.Boca.Boca Boca_Boca { get; set; }
        [ForeignKey("Grosor_de_Labios")]
        public virtual Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios Grosor_de_Labios_Grosor_de_Labios { get; set; }
        [ForeignKey("Menton")]
        public virtual Spartane.Core.Domain.Menton.Menton Menton_Menton { get; set; }
        [ForeignKey("Forma_de_Menton")]
        public virtual Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton Forma_de_Menton_Forma_de_Menton { get; set; }
        [ForeignKey("Barba")]
        public virtual Spartane.Core.Domain.Barba.Barba Barba_Barba { get; set; }
        [ForeignKey("Forma_Orejas")]
        public virtual Spartane.Core.Domain.Forma_Orejas.Forma_Orejas Forma_Orejas_Forma_Orejas { get; set; }
        [ForeignKey("Tamano_Orejas")]
        public virtual Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas Tamano_Orejas_Tamano_Orejas { get; set; }
        [ForeignKey("Tipo_Lobulo")]
        public virtual Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo Tipo_Lobulo_Tipo_Lobulo { get; set; }
        [ForeignKey("Bigote")]
        public virtual Spartane.Core.Domain.Bigote.Bigote Bigote_Bigote { get; set; }
        [ForeignKey("Senas_Particulares")]
        public virtual Spartane.Core.Domain.Senas_Particulares.Senas_Particulares Senas_Particulares_Senas_Particulares { get; set; }
        [ForeignKey("Imagen_Tatuaje")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Imagen_Tatuaje_Spartane_File { get; set; }
        [ForeignKey("Situacion_Fisica")]
        public virtual Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica Situacion_Fisica_Situacion_Fisica { get; set; }

    }

	public class Quejas_de_MP_Hechos_Sucedidos
    {
                public int Clave { get; set; }
        public string Descripcion_de_los_Hechos { get; set; }
        public DateTime? Fecha_de_los_Hechos { get; set; }
        public string Hora_de_los_Hechos { get; set; }
        public int? Municipio_hechos { get; set; }
        public int? Poblacion_hechos { get; set; }
        public int? Colonia_hechos { get; set; }
        public string Calle_hechos { get; set; }
        public string Entre_Calle_hechos { get; set; }
        public string Y_Calle_hechos { get; set; }
        public string Numero_Exterior_hechos { get; set; }
        public string Numero_Interior_hechos { get; set; }
        public int? Codigo_Postal_hechos { get; set; }
        public string Referencia { get; set; }

		        [ForeignKey("Municipio_hechos")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_hechos_Municipio { get; set; }
        [ForeignKey("Poblacion_hechos")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_hechos_Colonia { get; set; }
        [ForeignKey("Colonia_hechos")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_hechos_Colonia { get; set; }

    }

	public class Quejas_de_MP_Identificacion_del_Servidor_Publico
    {
                public int Clave { get; set; }
        public string CURP_Identificacion { get; set; }
        public string Nombres_Identificacion { get; set; }
        public string Apellido_Paterno_Identificacion { get; set; }
        public string Apellido_Materno_Identificacion { get; set; }
        public string Alias { get; set; }
        public DateTime? Fecha_Nacimiento_Identificacion { get; set; }
        public int? Edad_Identificacion { get; set; }
        public int? Genero_Identificacion { get; set; }
        public string Celular_Identificacion { get; set; }
        public string Correo_Identificacion { get; set; }
        public int? Tipo_de_Identificacion_Identificacion { get; set; }
        public string Numero_Identificacion_Identificacion { get; set; }
        public int? Nacionalidad_Identificacion { get; set; }
        public int? Entidad_de_Nacimiento_Identificacion { get; set; }

		        [ForeignKey("Genero_Identificacion")]
        public virtual Spartane.Core.Domain.Genero.Genero Genero_Identificacion_Genero { get; set; }
        [ForeignKey("Tipo_de_Identificacion_Identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Identificacion_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Nacionalidad_Identificacion")]
        public virtual Spartane.Core.Domain.Nacionalidad.Nacionalidad Nacionalidad_Identificacion_Nacionalidad { get; set; }
        [ForeignKey("Entidad_de_Nacimiento_Identificacion")]
        public virtual Spartane.Core.Domain.Estado.Estado Entidad_de_Nacimiento_Identificacion_Estado { get; set; }

    }

	public class Quejas_de_MP_Domicilio_del_Servidor_Publico
    {
                public int Clave { get; set; }
        public int? Municipio { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia { get; set; }
        public string Calle { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Codigo_Postal { get; set; }
        public string Referencias_de_domicilio { get; set; }

		        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }

    }


}

