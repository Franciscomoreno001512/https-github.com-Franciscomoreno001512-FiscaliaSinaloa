using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Plazo_de_Investigacion_Complementaria
{
    public interface IPlazo_de_Investigacion_ComplementariaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria.Plazo_de_Investigacion_Complementaria>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria.Plazo_de_Investigacion_Complementaria>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria.Plazo_de_Investigacion_Complementaria> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria.Plazo_de_Investigacion_ComplementariaPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Plazo_de_Investigacion_ComplementariaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria.Plazo_de_Investigacion_Complementaria entity, Spartane.Core.Domain.User.GlobalData Plazo_de_Investigacion_ComplementariaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria.Plazo_de_Investigacion_Complementaria entity, Spartane.Core.Domain.User.GlobalData Plazo_de_Investigacion_ComplementariaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria.Plazo_de_Investigacion_Complementaria>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria.Plazo_de_Investigacion_Complementaria>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria.Plazo_de_Investigacion_Complementaria>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria.Plazo_de_Investigacion_ComplementariaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria.Plazo_de_Investigacion_Complementaria>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria.Plazo_de_Investigacion_Complementaria_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria.Plazo_de_Investigacion_Complementaria_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

