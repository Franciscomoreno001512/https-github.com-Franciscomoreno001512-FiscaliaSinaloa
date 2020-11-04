using System;
using Spartane.Core.Domain.Relacion_Unidad_Usuario;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Relacion_Unidad_Usuario
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IRelacion_Unidad_UsuarioService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_UsuarioPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
