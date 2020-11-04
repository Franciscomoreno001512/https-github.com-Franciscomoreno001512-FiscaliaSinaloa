using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Juez_de_Control
{
    public interface IJuez_de_ControlApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Juez_de_Control.Juez_de_Control>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Juez_de_Control.Juez_de_Control>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Juez_de_Control.Juez_de_Control> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Juez_de_Control.Juez_de_ControlPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Juez_de_ControlInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Juez_de_Control.Juez_de_Control entity, Spartane.Core.Domain.User.GlobalData Juez_de_ControlInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Juez_de_Control.Juez_de_Control entity, Spartane.Core.Domain.User.GlobalData Juez_de_ControlInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Juez_de_Control.Juez_de_Control>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Juez_de_Control.Juez_de_Control>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Juez_de_Control.Juez_de_Control>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Juez_de_Control.Juez_de_ControlPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Juez_de_Control.Juez_de_Control>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Juez_de_Control.Juez_de_Control_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Juez_de_Control.Juez_de_Control_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

