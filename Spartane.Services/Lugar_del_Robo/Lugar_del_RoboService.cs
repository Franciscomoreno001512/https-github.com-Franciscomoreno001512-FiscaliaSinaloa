using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Lugar_del_Robo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Lugar_del_Robo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Lugar_del_RoboService : ILugar_del_RoboService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Lugar_del_Robo.Lugar_del_Robo> _Lugar_del_RoboRepository;
        #endregion

        #region Ctor
        public Lugar_del_RoboService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Lugar_del_Robo.Lugar_del_Robo> Lugar_del_RoboRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Lugar_del_RoboRepository = Lugar_del_RoboRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Lugar_del_Robo.Lugar_del_Robo> SelAll(bool ConRelaciones)
        {
            return this._Lugar_del_RoboRepository.Table.ToList();
        }

        public IList<Core.Domain.Lugar_del_Robo.Lugar_del_Robo> SelAllComplete(bool ConRelaciones)
        {
            return this._Lugar_del_RoboRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Lugar_del_Robo.Lugar_del_Robo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Lugar_del_RoboRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Lugar_del_Robo.Lugar_del_Robo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Lugar_del_RoboRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Lugar_del_Robo.Lugar_del_Robo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Lugar_del_RoboRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Lugar_del_Robo.Lugar_del_RoboPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Lugar_del_RoboPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Lugar_del_Robo.Lugar_del_Robo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Lugar_del_RoboRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Lugar_del_Robo.Lugar_del_Robo GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Lugar_del_Robo.Lugar_del_Robo result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Lugar_del_RoboInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Lugar_del_Robo.Lugar_del_Robo entity, Spartane.Core.Domain.User.GlobalData Lugar_del_RoboInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Lugar_del_Robo.Lugar_del_Robo entity, Spartane.Core.Domain.User.GlobalData Lugar_del_RoboInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

