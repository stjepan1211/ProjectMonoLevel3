vehicleApp.controller('vmkAddController', function ($scope, $http, $window, $location) {
    
    $scope.addVehicleMake = function () {
        if ($scope.Name != null && $scope.Abrv != null) {
            var obj = { Name: $scope.Name, Abrv: $scope.Abrv };
            $http.post('/api/VehicleMake/AddVmk', obj).success(function (data) {
                $scope.response = data;
                console.log(data);
                $window.alert("Success");
            })
            .error(function (data) {
                $scope.error = "An error has occured while trying to add maker";
                $window.alert("Error! " + data.Message);
            });
        }
        else {
            $window.alert("Potrebno je popuniti oba polja.");
        }
    }
});
