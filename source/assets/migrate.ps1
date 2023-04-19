Param (
    [Parameter(Mandatory = $false)][string]$MigratorBinPath = 'F:\ConversionTool-PbJava\drop\bin\Pb2JavaRunner\Release',
    [Parameter(Mandatory = $false)][string]$MigrationOutPutPath = 'F:\WebMAPDemos\src\PBJava\TailwindProductCatalog\OutputDir',
    [Parameter(Mandatory = $false)][string]$SourceFolder = 'F:\WebMAPDemos\src\PBJava\TailwindProductCatalog',
    [Parameter(Mandatory = $false)][string]$ServerFolder = 'F:\apache-tomcat-8.5.37',
    [Parameter(Mandatory = $false)][string]$WebFolder = 'F:\WebMAPDemos\src\PBJava\TailwindProductCatalog\OutputDir\WebApp\productcatalogSite\productcatalogSite-angular',
    [Parameter(Mandatory = $false)][string]$WebFolderForDeployment = 'F:\WebMAPDemos\src\PBJava\TailwindProductCatalog\OutputDir\WebApp\productcatalogSite\wwwroot',
    [Parameter(Mandatory = $false)][string]$HelpersFolder = 'F:\PBJavaHelpers'
)


function MigrationInitialSetup($Output, $ServerPath){
    Write-Host "Executing MigrationInitialSetup"
    if(test-path $Output){
        Remove-Item –path $Output –recurse -Force
    }    
    if(-not (test-path $Output)){
        New-Item -ItemType directory -Path $Output 
    }  

    &$ServerPath\bin\shutdown.bat
}

function MigratePBCode($Src, $Output){
    Write-Host "Executing MigratePBCode"
    if((test-path $MigratorBinPath) -and (test-path $Src)){
        Set-Location $MigratorBinPath
        .\Artinsoft.Pb2Java.Runner.exe -i $SourceFolder -o $MigrationOutPutPath --skipMastersaf -p com.tailwind
    }    
    ShutdownProc -ProcName "Artinsoft.Pb2Java.Runner"
}


function GenerateWebSolution($WebPath){
    if(test-path $WebPath){
        Set-Location $WebPath
        yarn install 
        ng build
    }    
}

function CopyMigratedCodeInReferenceApplication($WebPath, $Output){
    if((test-path $WebPath) -and (test-path $Output\ReferenceApplication\src\main\webapp)){
        Copy-Item $WebPath\* -Destination $Output\ReferenceApplication\src\main\webapp -Recurse 
    }    
}

function HelpersCompilation($ProjectPath){
    if(test-path $ProjectPath){
        Set-Location $ProjectPath
        mvn clean install -DskipTests
    }   
}

function TargetCompilation($Output){
    if(test-path $Output\Target){
        Set-Location $Output\Target
        mvn clean install 
    }   
}


function WarGeneration($Output){
    if(test-path $Output\ReferenceApplication){
        Set-Location $Output\ReferenceApplication
        mvn clean install 
    }   
}


function CopyWarToServer($Output, $ServerPath){
    if((test-path $Output\ReferenceApplication\target\ws-1.0.0.war) -and (test-path $ServerPath)){
        Move-Item $Output\ReferenceApplication\target\ws-1.0.0.war $Output\ReferenceApplication\target\ws.war
        Copy-Item $Output\ReferenceApplication\target\ws.war -Destination $ServerPath\webapps -Recurse 
    }    
}


function ServerStartup($ServerPath){
    if(test-path $ServerPath){
        &$ServerPath\bin\startup.bat
    } 
    
}

Write-Output "Start MigrationInitialSetup"
#MigrationInitialSetup -Output $MigrationOutPutPath -ServerPath $ServerFolder
Write-Output "End MigrationInitialSetup"

Write-Output "Start MigratePBCode"
#MigratePBCode -Src $SourceFolder -Output $MigrationOutPutPath
Write-Output "End MigratePBCode"

Write-Output "Start GenerateWebSolution"
#GenerateWebSolution $WebFolder
Write-Output "End GenerateWebSolution"

Write-Output "Start CopyMigratedCodeInReferenceApplication"
#CopyMigratedCodeInReferenceApplication -WebPath $WebFolderForDeployment -Output $MigrationOutPutPath
Write-Output "End CopyMigratedCodeInReferenceApplication"

Write-Output "Start HelpersCompilation"
HelpersCompilation $HelpersFolder
Write-Output "End HelpersCompilation"

Write-Output "Start TargetCompilation"
TargetCompilation $MigrationOutPutPath
Write-Output "End TargetCompilation"

WarGeneration $MigrationOutPutPath 

CopyWarToServer -Output $MigrationOutPutPath -ServerPath $ServerFolder

ServerStartup $ServerFolder



