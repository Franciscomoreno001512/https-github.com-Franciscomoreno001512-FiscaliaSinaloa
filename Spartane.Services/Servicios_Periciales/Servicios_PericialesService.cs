using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Servicios_Periciales;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Servicios_Periciales
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Servicios_PericialesService : IServicios_PericialesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales> _Servicios_PericialesRepository;
        #endregion

        #region Ctor
        public Servicios_PericialesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales> Servicios_PericialesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Servicios_PericialesRepository = Servicios_PericialesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales> SelAll(bool ConRelaciones)
        {
            return this._Servicios_PericialesRepository.Table.ToList();
        }

        public IList<Core.Domain.Servicios_Periciales.Servicios_Periciales> SelAllComplete(bool ConRelaciones)
        {
            return this._Servicios_PericialesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Servicios_PericialesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Servicios_PericialesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Servicios_PericialesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Servicios_Periciales.Servicios_PericialesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Servicios_PericialesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Servicios_PericialesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Servicios_PericialesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales entity, Spartane.Core.Domain.User.GlobalData Servicios_PericialesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales entity, Spartane.Core.Domain.User.GlobalData Servicios_PericialesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

