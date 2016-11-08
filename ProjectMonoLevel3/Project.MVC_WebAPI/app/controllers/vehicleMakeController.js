vehicleApp.controller('vehicleMakeController', function ($scope, $http) {
    $http.get('/api/VehicleMake/GetAllVmk')
    .success(function (response) {
        $scope.vehicleMakes = response;
    })
    .error(function () {
        return "error";
    });
});
