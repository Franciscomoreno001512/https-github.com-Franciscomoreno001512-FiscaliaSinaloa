using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Estudios_Superiores;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Estudios_Superiores
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Estudios_SuperioresService : IEstudios_SuperioresService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Estudios_Superiores.Estudios_Superiores> _Estudios_SuperioresRepository;
        #endregion

        #region Ctor
        public Estudios_SuperioresService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Estudios_Superiores.Estudios_Superiores> Estudios_SuperioresRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Estudios_SuperioresRepository = Estudios_SuperioresRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Estudios_Superiores.Estudios_Superiores> SelAll(bool ConRelaciones)
        {
            return this._Estudios_SuperioresRepository.Table.ToList();
        }

        public IList<Core.Domain.Estudios_Superiores.Estudios_Superiores> SelAllComplete(bool ConRelaciones)
        {
            return this._Estudios_SuperioresRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Estudios_Superiores.Estudios_Superiores> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estudios_SuperioresRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estudios_Superiores.Estudios_Superiores> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Estudios_SuperioresRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estudios_Superiores.Estudios_Superiores> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estudios_SuperioresRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estudios_Superiores.Estudios_SuperioresPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Estudios_SuperioresPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Estudios_Superiores.Estudios_Superiores> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Estudios_SuperioresRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estudios_Superiores.Estudios_Superiores GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Estudios_Superiores.Estudios_Superiores result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Estudios_SuperioresInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Estudios_Superiores.Estudios_Superiores entity, Spartane.Core.Domain.User.GlobalData Estudios_SuperioresInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Estudios_Superiores.Estudios_Superiores entity, Spartane.Core.Domain.User.GlobalData Estudios_SuperioresInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

