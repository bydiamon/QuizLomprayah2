@ModelType QuizLomprayah2.EmployeeInformation
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>EmployeeInformation</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.employee_ID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.employee_ID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LastName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LastName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Department)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Department)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.StartDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.StartDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.BranchTable.Branch_Title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BranchTable.Branch_Title)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PositionTable.Position_Title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PositionTable.Position_Title)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
