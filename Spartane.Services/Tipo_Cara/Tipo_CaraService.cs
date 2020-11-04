using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_Cara;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_Cara
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_CaraService : ITipo_CaraService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_Cara.Tipo_Cara> _Tipo_CaraRepository;
        #endregion

        #region Ctor
        public Tipo_CaraService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_Cara.Tipo_Cara> Tipo_CaraRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_CaraRepository = Tipo_CaraRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_Cara.Tipo_Cara> SelAll(bool ConRelaciones)
        {
            return this._Tipo_CaraRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_Cara.Tipo_Cara> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_CaraRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_Cara.Tipo_Cara> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_CaraRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_Cara.Tipo_Cara> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_CaraRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_Cara.Tipo_Cara> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_CaraRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_Cara.Tipo_CaraPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_CaraPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_Cara.Tipo_Cara> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_CaraRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_Cara.Tipo_Cara GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_Cara.Tipo_Cara result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Tipo_CaraInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Tipo_Cara.Tipo_Cara entity, Spartane.Core.Domain.User.GlobalData Tipo_CaraInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Tipo_Cara.Tipo_Cara entity, Spartane.Core.Domain.User.GlobalData Tipo_CaraInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

