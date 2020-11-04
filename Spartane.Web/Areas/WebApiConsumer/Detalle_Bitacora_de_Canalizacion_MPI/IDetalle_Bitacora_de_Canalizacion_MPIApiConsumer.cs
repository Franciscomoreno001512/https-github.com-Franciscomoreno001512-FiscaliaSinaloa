using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_Bitacora_de_Canalizacion_MPI
{
    public interface IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI.Detalle_Bitacora_de_Canalizacion_MPI>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI.Detalle_Bitacora_de_Canalizacion_MPI>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI.Detalle_Bitacora_de_Canalizacion_MPI> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI.Detalle_Bitacora_de_Canalizacion_MPIPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Bitacora_de_Canalizacion_MPIInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI.Detalle_Bitacora_de_Canalizacion_MPI entity, Spartane.Core.Domain.User.GlobalData Detalle_Bitacora_de_Canalizacion_MPIInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI.Detalle_Bitacora_de_Canalizacion_MPI entity, Spartane.Core.Domain.User.GlobalData Detalle_Bitacora_de_Canalizacion_MPIInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI.Detalle_Bitacora_de_Canalizacion_MPI>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI.Detalle_Bitacora_de_Canalizacion_MPI>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI.Detalle_Bitacora_de_Canalizacion_MPI>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI.Detalle_Bitacora_de_Canalizacion_MPIPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI.Detalle_Bitacora_de_Canalizacion_MPI>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI.Detalle_Bitacora_de_Canalizacion_MPI_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI.Detalle_Bitacora_de_Canalizacion_MPI_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

