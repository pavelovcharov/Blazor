using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    class ProductsFlatProvider : RemoteDataProviderBase, IProductsFlatProvider {
        public ProductsFlatProvider(RemoteDataProviderLoader loader) : base(loader) {
        }

        public Task<IEnumerable<ProductFlat>> GetProductsAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetProductsAsync);
        }

        public Task Add(ProductFlat product) {
            return Loader.AddEntity(this, product);
        }

        public Task Remove(ProductFlat item) {
            return Loader.DeleteEntity(this, item);
        }
        public Task Update(ProductFlat item, IDictionary<string, object> newValue) {
            return Task.CompletedTask;
        }
    }
}
