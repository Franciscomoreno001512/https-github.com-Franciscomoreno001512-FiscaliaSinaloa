using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Etnia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Etnia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class EtniaService : IEtniaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Etnia.Etnia> _EtniaRepository;
        #endregion

        #region Ctor
        public EtniaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Etnia.Etnia> EtniaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._EtniaRepository = EtniaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Etnia.Etnia> SelAll(bool ConRelaciones)
        {
            return this._EtniaRepository.Table.ToList();
        }

        public IList<Core.Domain.Etnia.Etnia> SelAllComplete(bool ConRelaciones)
        {
            return this._EtniaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Etnia.Etnia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._EtniaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Etnia.Etnia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._EtniaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Etnia.Etnia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._EtniaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Etnia.EtniaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            EtniaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Etnia.Etnia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._EtniaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Etnia.Etnia GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Etnia.Etnia result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EtniaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Etnia.Etnia entity, Spartane.Core.Domain.User.GlobalData EtniaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Etnia.Etnia entity, Spartane.Core.Domain.User.GlobalData EtniaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

