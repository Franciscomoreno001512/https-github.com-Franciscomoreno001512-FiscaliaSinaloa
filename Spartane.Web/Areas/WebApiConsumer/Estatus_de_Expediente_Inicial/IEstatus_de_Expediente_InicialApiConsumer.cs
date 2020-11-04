using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Estatus_de_Expediente_Inicial
{
    public interface IEstatus_de_Expediente_InicialApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_InicialPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Estatus_de_Expediente_InicialInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial entity, Spartane.Core.Domain.User.GlobalData Estatus_de_Expediente_InicialInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial entity, Spartane.Core.Domain.User.GlobalData Estatus_de_Expediente_InicialInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_InicialPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

