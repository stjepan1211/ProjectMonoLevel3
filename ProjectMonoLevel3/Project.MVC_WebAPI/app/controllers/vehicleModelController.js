vehicleApp.controller('vehicleModelController', function ($scope, $http) {
    $http.get('/api/VehicleModel/getAllVml')
    .success(function (response) {
        $scope.vehicleModels = response;
    })
    .error(function () {
        return "error";
    });
});