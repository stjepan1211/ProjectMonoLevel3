angular.module('vehicleApp').controller('vmkEditController', ['$scope', '$http', '$stateParams', '$window', vmkEditController]);

function vmkEditController($scope, $http,$stateParams, $window) {

    var id = $stateParams.VmkId;

    $scope.updateInit = function () {
        $http.get('/api/VehicleMake/GetVmk?id=' + id).success(function (data) {
            $scope.data = data;
        })
        .error(function (data) {
            $window.alert("Error! " + data.Message);
        })
    }

    $scope.update = function () {
        if ($scope.Name != null && $scope.Abrv != null){
            var vmk = {
                VehicleMakeId: $scope.data.VehicleMakeId,
                Name: $scope.Name,
                Abrv: $scope.Abrv
            };
            $http.put('api/VehicleMake/UpdateVmk?id=' + id, vmk).success(function (data){
                $window.alert("Updated");
            })
        }
        else {
            $window.alert("Potrebno je popuniti oba polja");
        }
    }
}
