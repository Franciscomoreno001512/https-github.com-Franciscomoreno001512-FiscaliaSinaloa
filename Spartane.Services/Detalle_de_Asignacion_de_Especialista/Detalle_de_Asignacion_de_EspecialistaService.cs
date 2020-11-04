using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_Asignacion_de_Especialista
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_Asignacion_de_EspecialistaService : IDetalle_de_Asignacion_de_EspecialistaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> _Detalle_de_Asignacion_de_EspecialistaRepository;
        #endregion

        #region Ctor
        public Detalle_de_Asignacion_de_EspecialistaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> Detalle_de_Asignacion_de_EspecialistaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_Asignacion_de_EspecialistaRepository = Detalle_de_Asignacion_de_EspecialistaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_Asignacion_de_EspecialistaRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_Asignacion_de_EspecialistaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Asignacion_de_EspecialistaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_Asignacion_de_EspecialistaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Asignacion_de_EspecialistaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_EspecialistaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_Asignacion_de_EspecialistaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_Asignacion_de_EspecialistaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Asignacion_de_EspecialistaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Asignacion_de_EspecialistaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Asignacion_de_EspecialistaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

