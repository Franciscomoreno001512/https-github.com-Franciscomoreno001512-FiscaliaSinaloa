using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Circunstancia_Vehiculo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Circunstancia_Vehiculo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Circunstancia_VehiculoService : ICircunstancia_VehiculoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo> _Circunstancia_VehiculoRepository;
        #endregion

        #region Ctor
        public Circunstancia_VehiculoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo> Circunstancia_VehiculoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Circunstancia_VehiculoRepository = Circunstancia_VehiculoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo> SelAll(bool ConRelaciones)
        {
            return this._Circunstancia_VehiculoRepository.Table.ToList();
        }

        public IList<Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo> SelAllComplete(bool ConRelaciones)
        {
            return this._Circunstancia_VehiculoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Circunstancia_VehiculoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Circunstancia_VehiculoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Circunstancia_VehiculoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_VehiculoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Circunstancia_VehiculoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Circunstancia_VehiculoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Circunstancia_VehiculoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo entity, Spartane.Core.Domain.User.GlobalData Circunstancia_VehiculoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo entity, Spartane.Core.Domain.User.GlobalData Circunstancia_VehiculoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

