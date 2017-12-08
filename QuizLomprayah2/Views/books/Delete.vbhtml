@ModelType QuizLomprayah2.book
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>book</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.subject_code)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.subject_code)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Name_book)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name_book)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.type_book)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.type_book)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Date_Start_Book)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Date_Start_Book)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Creator)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Creator)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FilePath)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FilePath)
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
