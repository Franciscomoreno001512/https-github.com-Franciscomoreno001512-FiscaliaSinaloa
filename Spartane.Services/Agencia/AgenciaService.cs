using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Agencia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Agencia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class AgenciaService : IAgenciaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Agencia.Agencia> _AgenciaRepository;
        #endregion

        #region Ctor
        public AgenciaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Agencia.Agencia> AgenciaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._AgenciaRepository = AgenciaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Agencia.Agencia> SelAll(bool ConRelaciones)
        {
            return this._AgenciaRepository.Table.ToList();
        }

        public IList<Core.Domain.Agencia.Agencia> SelAllComplete(bool ConRelaciones)
        {
            return this._AgenciaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Agencia.Agencia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AgenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Agencia.Agencia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._AgenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Agencia.Agencia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AgenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Agencia.AgenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            AgenciaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Agencia.Agencia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._AgenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Agencia.Agencia GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Agencia.Agencia result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData AgenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Agencia.Agencia entity, Spartane.Core.Domain.User.GlobalData AgenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Agencia.Agencia entity, Spartane.Core.Domain.User.GlobalData AgenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

