using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Marca_de_Arma;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Marca_de_Arma
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Marca_de_ArmaService : IMarca_de_ArmaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma> _Marca_de_ArmaRepository;
        #endregion

        #region Ctor
        public Marca_de_ArmaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma> Marca_de_ArmaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Marca_de_ArmaRepository = Marca_de_ArmaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma> SelAll(bool ConRelaciones)
        {
            return this._Marca_de_ArmaRepository.Table.ToList();
        }

        public IList<Core.Domain.Marca_de_Arma.Marca_de_Arma> SelAllComplete(bool ConRelaciones)
        {
            return this._Marca_de_ArmaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Marca_de_ArmaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Marca_de_ArmaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Marca_de_ArmaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Marca_de_Arma.Marca_de_ArmaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Marca_de_ArmaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Marca_de_ArmaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Marca_de_ArmaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma entity, Spartane.Core.Domain.User.GlobalData Marca_de_ArmaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma entity, Spartane.Core.Domain.User.GlobalData Marca_de_ArmaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

