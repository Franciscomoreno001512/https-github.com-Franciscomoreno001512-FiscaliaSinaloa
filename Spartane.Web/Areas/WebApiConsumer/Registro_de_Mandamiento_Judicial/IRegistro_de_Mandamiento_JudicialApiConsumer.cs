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

		ApiResponse<int> Update_Proceso(Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Proceso entity);
		ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Proceso> Get_Proceso(string Key);

		ApiResponse<int> Update_Expediente(Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Expediente entity);
		ApiResponse<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Expediente> Get_Expediente(string Key);


    }
}

