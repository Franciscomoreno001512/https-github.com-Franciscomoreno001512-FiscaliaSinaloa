using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_de_Droga;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_de_Droga
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_de_DrogaService : ITipo_de_DrogaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga> _Tipo_de_DrogaRepository;
        #endregion

        #region Ctor
        public Tipo_de_DrogaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga> Tipo_de_DrogaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_de_DrogaRepository = Tipo_de_DrogaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga> SelAll(bool ConRelaciones)
        {
            return this._Tipo_de_DrogaRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_de_Droga.Tipo_de_Droga> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_de_DrogaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_DrogaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_de_DrogaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_DrogaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_DrogaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_de_DrogaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_de_DrogaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Tipo_de_DrogaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga entity, Spartane.Core.Domain.User.GlobalData Tipo_de_DrogaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga entity, Spartane.Core.Domain.User.GlobalData Tipo_de_DrogaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

