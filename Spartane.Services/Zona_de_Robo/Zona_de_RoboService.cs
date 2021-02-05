using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Zona_de_Robo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Zona_de_Robo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Zona_de_RoboService : IZona_de_RoboService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo> _Zona_de_RoboRepository;
        #endregion

        #region Ctor
        public Zona_de_RoboService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo> Zona_de_RoboRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Zona_de_RoboRepository = Zona_de_RoboRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo> SelAll(bool ConRelaciones)
        {
            return this._Zona_de_RoboRepository.Table.ToList();
        }

        public IList<Core.Domain.Zona_de_Robo.Zona_de_Robo> SelAllComplete(bool ConRelaciones)
        {
            return this._Zona_de_RoboRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Zona_de_RoboRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Zona_de_RoboRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Zona_de_RoboRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Zona_de_Robo.Zona_de_RoboPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Zona_de_RoboPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Zona_de_RoboRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Zona_de_RoboInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo entity, Spartane.Core.Domain.User.GlobalData Zona_de_RoboInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo entity, Spartane.Core.Domain.User.GlobalData Zona_de_RoboInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

