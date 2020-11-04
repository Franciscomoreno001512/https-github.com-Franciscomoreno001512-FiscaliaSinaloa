using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Servicio_Medico;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Servicio_Medico
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Servicio_MedicoService : IServicio_MedicoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Servicio_Medico.Servicio_Medico> _Servicio_MedicoRepository;
        #endregion

        #region Ctor
        public Servicio_MedicoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Servicio_Medico.Servicio_Medico> Servicio_MedicoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Servicio_MedicoRepository = Servicio_MedicoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Servicio_Medico.Servicio_Medico> SelAll(bool ConRelaciones)
        {
            return this._Servicio_MedicoRepository.Table.ToList();
        }

        public IList<Core.Domain.Servicio_Medico.Servicio_Medico> SelAllComplete(bool ConRelaciones)
        {
            return this._Servicio_MedicoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Servicio_Medico.Servicio_Medico> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Servicio_MedicoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Servicio_Medico.Servicio_Medico> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Servicio_MedicoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Servicio_Medico.Servicio_Medico> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Servicio_MedicoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Servicio_Medico.Servicio_MedicoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Servicio_MedicoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Servicio_Medico.Servicio_Medico> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Servicio_MedicoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Servicio_Medico.Servicio_Medico GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Servicio_Medico.Servicio_Medico result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Servicio_MedicoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Servicio_Medico.Servicio_Medico entity, Spartane.Core.Domain.User.GlobalData Servicio_MedicoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Servicio_Medico.Servicio_Medico entity, Spartane.Core.Domain.User.GlobalData Servicio_MedicoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

