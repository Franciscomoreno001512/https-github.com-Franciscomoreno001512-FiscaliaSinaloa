using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Registro_de_Mandamiento_Judicial
{
    public interface IRegistro_de_Mandamiento_JudicialApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_JudicialPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Registro_de_Mandamiento_JudicialInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial entity, Spartane.Core.Domain.User.GlobalData Registro_de_Mandamiento_JudicialInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial entity, Spartane.Core.Domain.User.GlobalData Registro_de_Mandamiento_JudicialInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_JudicialPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Domicilio(Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Domicilio entity);
		ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Domicilio> Get_Domicilio(string Key);

		ApiResponse<int> Update_Telefonos(Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Telefonos entity);
		ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Telefonos> Get_Telefonos(string Key);

		ApiResponse<int> Update_Otros_Nombres(Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Otros_Nombres entity);
		ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Otros_Nombres> Get_Otros_Nombres(string Key);

		ApiResponse<int> Update_Datos_de_la_Orden(Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Datos_de_la_Orden entity);
		ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Datos_de_la_Orden> Get_Datos_de_la_Orden(string Key);

		ApiResponse<int> Update_Delito(Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Delito entity);
		ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Delito> Get_Delito(string Key);

		ApiResponse<int> Update_Amparo(Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Amparo entity);
		ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Amparo> Get_Amparo(string Key);

		ApiResponse<int> Update_Media_Filiacion(Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Media_Filiacion entity);
		ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Media_Filiacion> Get_Media_Filiacion(string Key);

		ApiResponse<int> Update_Proceso(Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Proceso entity);
		ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Proceso> Get_Proceso(string Key);

		ApiResponse<int> Update_Fotos(Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Fotos entity);
		ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Fotos> Get_Fotos(string Key);

		ApiResponse<int> Update_Documentos(Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Documentos entity);
		ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Documentos> Get_Documentos(string Key);

		ApiResponse<int> Update_Huellas_Digitales(Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Huellas_Digitales entity);
		ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Huellas_Digitales> Get_Huellas_Digitales(string Key);


    }
}

