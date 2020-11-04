using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Motivo_de_no_Acuerdo
{
    public interface IMotivo_de_no_AcuerdoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_AcuerdoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Motivo_de_no_AcuerdoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo entity, Spartane.Core.Domain.User.GlobalData Motivo_de_no_AcuerdoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo entity, Spartane.Core.Domain.User.GlobalData Motivo_de_no_AcuerdoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_AcuerdoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

