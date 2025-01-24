using module ..\bin\Debug\netstandard2.0\ProjectName.dll

Describe "ProjectName" {
	Context "When invoking" {
		It "Should say hello" {
			Get-Cmdlet -Parameter1 'Example' |
				Should Be "Hello Example"
		}
	}
}
