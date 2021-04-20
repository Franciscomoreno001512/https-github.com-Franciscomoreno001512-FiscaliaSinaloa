using System;
using Spartane.Core.Domain.Lugar_del_Hallazgo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Lugar_del_Hallazgo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ILugar_del_HallazgoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_HallazgoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
