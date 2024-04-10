using Microsoft.Extensions.DependencyInjection;

namespace KeyedServices
{
    public class TaxServiceTests
    {
        [Fact]
        public void should_register_keyed_service()
        {
            _serviceCollection.AddKeyedTransient<ITaxService, TaxService>("vat");
            var serviceProvider = _serviceCollection.BuildServiceProvider();

            var taxService = serviceProvider.GetService<ITaxService>();
            var keyedTaxService = serviceProvider.GetKeyedService<ITaxService>("vat");

            Assert.Null(taxService);
            Assert.NotNull(keyedTaxService);
        }

        [Fact]
        public void should_register_transient_get_service_by_type_and_get_service_passing_null_service_key()
        {
            _serviceCollection.AddTransient<ITaxService, TaxService>();
            var serviceProvider = _serviceCollection.BuildServiceProvider();

            var taxService = serviceProvider.GetService<ITaxService>();
            var keyedTaxService = serviceProvider.GetKeyedService<ITaxService>("vat");
            var keyedNullTaxService = serviceProvider.GetKeyedService<ITaxService>(null);

            Assert.NotNull(taxService);
            Assert.Null(keyedTaxService);
            Assert.NotNull(keyedNullTaxService);
        }

        [Fact]
        public void given_more_than_one_registered_keyed_service_should_get_last_registered()
        {
            _serviceCollection.AddKeyedTransient<ITaxService, TaxService>("vat");
            _serviceCollection.AddKeyedTransient<ITaxService, TaxCService>("vat");
            var serviceProvider = _serviceCollection.BuildServiceProvider();

            var keyedTaxService = serviceProvider.GetKeyedService<ITaxService>("vat");

            Assert.NotNull(keyedTaxService);
            Assert.IsType<TaxCService>(keyedTaxService);
        }

        [Fact]
        public void given_more_than_one_registered_keyed_service_should_get_more_than_one_service_using_ienumerable()
        {
            _serviceCollection.AddKeyedTransient<ITaxService, TaxService>("vat");
            _serviceCollection.AddKeyedTransient<ITaxService, TaxCService>("vat");
            var serviceProvider = _serviceCollection.BuildServiceProvider();

            var keyedTaxServices = serviceProvider.GetKeyedService<IEnumerable<ITaxService>>("vat");
            var keyedTaxServices2 = serviceProvider.GetKeyedServices<ITaxService>("vat");

            Assert.NotNull(keyedTaxServices);
            Assert.NotNull(keyedTaxServices2);
            Assert.NotEmpty(keyedTaxServices);
            Assert.NotEmpty(keyedTaxServices2);
            Assert.True(keyedTaxServices.Any());
            Assert.True(keyedTaxServices.Count() > 1);
            Assert.True(keyedTaxServices2.Any());
            Assert.True(keyedTaxServices2.Count() > 1);
            Assert.Equal(keyedTaxServices.Count(), keyedTaxServices2.Count());
        }

        private readonly ServiceCollection _serviceCollection;

        public TaxServiceTests()
        {
            _serviceCollection = new ();
        }
    }
}