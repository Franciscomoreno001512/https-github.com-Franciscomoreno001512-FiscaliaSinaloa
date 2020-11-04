using System;
using Spartane.Core.Domain.Formato_de_Control;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Formato_de_Control
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IFormato_de_ControlService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Formato_de_Control.Formato_de_Control> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Formato_de_Control.Formato_de_Control> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Formato_de_Control.Formato_de_Control> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Formato_de_Control.Formato_de_Control GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Formato_de_Control.Formato_de_Control entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Formato_de_Control.Formato_de_Control entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Formato_de_Control.Formato_de_Control> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Formato_de_Control.Formato_de_Control> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Formato_de_Control.Formato_de_ControlPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Formato_de_Control.Formato_de_Control> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
