using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tamano_de_Nariz;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tamano_de_Nariz
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tamano_de_NarizService : ITamano_de_NarizService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tamano_de_Nariz.Tamano_de_Nariz> _Tamano_de_NarizRepository;
        #endregion

        #region Ctor
        public Tamano_de_NarizService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tamano_de_Nariz.Tamano_de_Nariz> Tamano_de_NarizRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tamano_de_NarizRepository = Tamano_de_NarizRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tamano_de_Nariz.Tamano_de_Nariz> SelAll(bool ConRelaciones)
        {
            return this._Tamano_de_NarizRepository.Table.ToList();
        }

        public IList<Core.Domain.Tamano_de_Nariz.Tamano_de_Nariz> SelAllComplete(bool ConRelaciones)
        {
            return this._Tamano_de_NarizRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tamano_de_Nariz.Tamano_de_Nariz> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tamano_de_NarizRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tamano_de_Nariz.Tamano_de_Nariz> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tamano_de_NarizRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tamano_de_Nariz.Tamano_de_Nariz> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tamano_de_NarizRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tamano_de_Nariz.Tamano_de_NarizPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tamano_de_NarizPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tamano_de_Nariz.Tamano_de_Nariz> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tamano_de_NarizRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tamano_de_Nariz.Tamano_de_Nariz GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tamano_de_Nariz.Tamano_de_Nariz result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Tamano_de_NarizInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Tamano_de_Nariz.Tamano_de_Nariz entity, Spartane.Core.Domain.User.GlobalData Tamano_de_NarizInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Tamano_de_Nariz.Tamano_de_Nariz entity, Spartane.Core.Domain.User.GlobalData Tamano_de_NarizInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

