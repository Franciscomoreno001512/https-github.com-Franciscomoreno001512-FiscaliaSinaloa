using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Cadena_de_Custodia
{
    public interface ICadena_de_CustodiaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_CustodiaPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Cadena_de_CustodiaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia entity, Spartane.Core.Domain.User.GlobalData Cadena_de_CustodiaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia entity, Spartane.Core.Domain.User.GlobalData Cadena_de_CustodiaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_CustodiaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Asignacion(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Asignacion entity);
		ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Asignacion> Get_Asignacion(string Key);

		ApiResponse<int> Update_Cadena_de_Custodia(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Cadena_de_Custodia entity);
		ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Cadena_de_Custodia> Get_Cadena_de_Custodia(string Key);

		ApiResponse<int> Update_Fijacion_Planimetrica(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Fijacion_Planimetrica entity);
		ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Fijacion_Planimetrica> Get_Fijacion_Planimetrica(string Key);

		ApiResponse<int> Update_Fotos(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Fotos entity);
		ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Fotos> Get_Fotos(string Key);

		ApiResponse<int> Update_Videos(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Videos entity);
		ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Videos> Get_Videos(string Key);

		ApiResponse<int> Update_Registro_de_Intervinientes(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Intervinientes entity);
		ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Intervinientes> Get_Registro_de_Intervinientes(string Key);

		ApiResponse<int> Update_Chat(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Chat entity);
		ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Chat> Get_Chat(string Key);

		ApiResponse<int> Update_Documentos(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Documentos entity);
		ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Documentos> Get_Documentos(string Key);

		ApiResponse<int> Update_Retroalimentacion(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Retroalimentacion entity);
		ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Retroalimentacion> Get_Retroalimentacion(string Key);

		ApiResponse<int> Update_Registro_de_Emergencia(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Emergencia entity);
		ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Emergencia> Get_Registro_de_Emergencia(string Key);

		ApiResponse<int> Update_Registro_de_Detenidos(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Detenidos entity);
		ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Detenidos> Get_Registro_de_Detenidos(string Key);

		ApiResponse<int> Update_Registro_de_Testigos(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Testigos entity);
		ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Testigos> Get_Registro_de_Testigos(string Key);

		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Asignaciones(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Asignaciones entity);
		ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Asignaciones> Get_Asignaciones(string Key);

		ApiResponse<int> Update_Datos_de_Traslado(Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Datos_de_Traslado entity);
		ApiResponse<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Datos_de_Traslado> Get_Datos_de_Traslado(string Key);


    }
}

