using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Idioma;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Idioma
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class IdiomaService : IIdiomaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Idioma.Idioma> _IdiomaRepository;
        #endregion

        #region Ctor
        public IdiomaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Idioma.Idioma> IdiomaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._IdiomaRepository = IdiomaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Idioma.Idioma> SelAll(bool ConRelaciones)
        {
            return this._IdiomaRepository.Table.ToList();
        }

        public IList<Core.Domain.Idioma.Idioma> SelAllComplete(bool ConRelaciones)
        {
            return this._IdiomaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Idioma.Idioma> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._IdiomaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Idioma.Idioma> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._IdiomaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Idioma.Idioma> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._IdiomaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Idioma.IdiomaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            IdiomaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Idioma.Idioma> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._IdiomaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Idioma.Idioma GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Idioma.Idioma result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData IdiomaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Idioma.Idioma entity, Spartane.Core.Domain.User.GlobalData IdiomaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Idioma.Idioma entity, Spartane.Core.Domain.User.GlobalData IdiomaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

