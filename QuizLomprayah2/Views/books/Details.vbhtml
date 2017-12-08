@ModelType QuizLomprayah2.book
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.book_ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
