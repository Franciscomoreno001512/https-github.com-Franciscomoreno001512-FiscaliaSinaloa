using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Probable_Responsable_PC
{
    public interface IProbable_Responsable_PCApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PCPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Probable_Responsable_PCInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC entity, Spartane.Core.Domain.User.GlobalData Probable_Responsable_PCInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC entity, Spartane.Core.Domain.User.GlobalData Probable_Responsable_PCInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PCPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Domicilio(Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC_Domicilio entity);
		ApiResponse<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC_Domicilio> Get_Domicilio(string Key);

		ApiResponse<int> Update_Datos_de_Media_Filiacion(Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC_Datos_de_Media_Filiacion entity);
		ApiResponse<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC_Datos_de_Media_Filiacion> Get_Datos_de_Media_Filiacion(string Key);


    }
}

