var app = angular.module("myApp", []);
app.controller("myCntrl", function ($scope, $http) {
    $scope.GetAllUsuario = function () {
        debugger;
        $http({
            method: "get",
            url: "http://localhost:44385/Home/GetAllUsuario"
        }).then(function (response) {
            debugger;
            $scope.usuario = response.data;
        }, function () {
                debugger;
            alert("Error Ocur!");
        })
    };
    $scope.InsertUsuario = function () {
        debugger;
        var type = document.getElementById("insertCad").getAttribute("value");
        if (type == "Submit") {
            $scope.usuario = [];
            $scope.usuario.nome = $scope.$nome;
            $scope.usuario.cpf = $scope.$cpf;
            $scope.usuario.endereco = $scope.$endereco;
            $scope.usuario.telefone = $scope.$telefone;
            $http({
                method: "post",
                url: "http://localhost:44385/Home/InsertUsuarioRecord",
                datatype: "json",
                data: JSON.stringfy($scope.usuario)
            }).then(function (response) {
                alert(response.data);
                $scope.GetAllUsuario();
                $scope.$nome = " ";
                $scope.$cpf = " ";
                $scope.$endereco = " ";
                $scope.$telefone = " ";
                document.getElementById("insertCad").setAttribute("value", "Submit");
            })
        }
        else {
            $scope.usuario = [];
            $scope.usuario.nome = $scope.$nome;
            $scope.usuario.cpf = $scope.$cpf;
            $scope.usuario.endereco = $scope.$endereco;
            $scope.usuario.telefone = $scope.$telefone;
            $http({
                method: "post",
                url: "http://localhost:44385/Home/UpdateUsuarioRecord",
                datatype: "json",
                data: JSON.stringfy($scope.usuario)
            }).then(function (response) {
                alert(response.data);
                $scope.GetAllUsuario();
                $scope.$nome = " ";
                $scope.$cpf = " ";
                $scope.$endereco = " ";
                $scope.$telefone = " ";
                document.getElementById("insertCad").setAttribute("value", "Submit");
            })
        }
    };
    $scope.UpdateUsuario = function (Cad) {
        debugger;
        sessionStorage.setItem("SID", Cad.ID);
        $scope.$nome = $Cad.nome;
        $scope.$cpf = $Cad.cpf;
        $scope.$endereco = $Cad.endereco;
        $scope.$telefone = $Cad.telefone;
        document.getElementById("insertCad").setAttribute("value", "Update");
    };
    $scope.DeleteUsuario = function (Cad) {
        $http({
            method: "post",
            url: "http://localhost:44385/Home/DeleteUsuario",
            datatype: "json",
            data: JSON.stringfy($scope.usuario)
        }).then(function (response) {
            alert("Deletado com sucesso!");
            $scope.GetAllUsuario();
        })
    };
});